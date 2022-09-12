using Iot.Admin.Application.Contracts.Devices;
using Iot.Admin.Application.Contracts.Devices.Views;
using Iot.Common.Jwt;
using Iot.Device;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Iot.Admin.Application.Devices;

/// <summary>
/// 设备树形
/// </summary>
public class TreeDeviceService : ApplicationService, ITreeDeviceService
{
    private readonly ITreeDeviceRepository _treeDeviceRepository;
    private readonly Accessor _accessor;
    private readonly IDevicesRepository _devicesRepository;

    /// <inheritdoc />
    public TreeDeviceService(ITreeDeviceRepository treeDeviceRepository, Accessor accessor,
        IDevicesRepository devicesRepository)
    {
        _treeDeviceRepository = treeDeviceRepository;
        _accessor = accessor;
        _devicesRepository = devicesRepository;
    }

    /// <inheritdoc />
    public async Task CreateAsync(TreeDeviceInput input)
    {
        var userId = _accessor.GetUserId();

        if (await _treeDeviceRepository.AnyAsync(x =>
                x.UserId == userId && x.ParentId == input.ParentId && x.Title == input.Title))
        {
            throw new BusinessException(IotDomainErrorCodes.ExistTreeDeviceTitle);
        }

        var data = ObjectMapper.Map<TreeDeviceInput, TreeDevice>(input);
        data.UserId = userId;

        await _treeDeviceRepository.InsertAsync(data);
    }

    /// <inheritdoc />
    public async Task UpdateAsync(TreeDeviceInput input)
    {
        var data = await _treeDeviceRepository.FirstOrDefaultAsync(x => x.Id == input.Id);

        data.Title = input.Title;
        data.Icon = input.Icon;
        data.ParentId = input.ParentId;

        await _treeDeviceRepository.UpdateAsync(data);
    }

    /// <inheritdoc />
    public async Task DeleteAsync(Guid id)
    {
        await _treeDeviceRepository.DeleteAsync(id);
    }

    /// <inheritdoc />
    public async Task<List<TreeDeviceDto>> GetTreeAsync(GetTreeDeviceInput input)
    {
        var userId = _accessor.GetUserId();

        var tree = await _treeDeviceRepository.GetListAsync(x => x.UserId == userId && x.ParentId == input.ParentId);

        var device = await _devicesRepository.GetListAsync(x => x.UserInfoId == userId && x.TreeId == input.ParentId);

        var treeDevice = new List<TreeDeviceDto>();

        treeDevice.AddRange(tree.Select(t => new TreeDeviceDto(t.Id, t.Title, t.Icon, t.ParentId)));

        treeDevice.AddRange(device.Select(x => new TreeDeviceDto(x.Id, x.Name, "", x.TreeId, true)));

        return treeDevice;
    }
}