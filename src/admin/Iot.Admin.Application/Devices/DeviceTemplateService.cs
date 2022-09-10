using Iot.Admin.Application.Contracts.Devices;
using Iot.Admin.Application.Contracts.Devices.Views;
using Iot.Common.Jwt;
using Iot.Device;
using Iot.Devices;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Iot.Admin.Application.Devices;

/// <summary>
/// 设备模板
/// </summary>
public class DeviceTemplateService : ApplicationService, IDeviceTemplateService
{
    private readonly IDeviceTemplateRepository _deviceTemplateRepository;
    private readonly Accessor _accessor;

    /// <inheritdoc />
    public DeviceTemplateService(IDeviceTemplateRepository deviceTemplateRepository, Accessor accessor)
    {
        _deviceTemplateRepository = deviceTemplateRepository;
        _accessor = accessor;
    }

    /// <inheritdoc />
    public async Task CreateAsync(CreateDeviceTemplate deviceTemplate)
    {
        var userId = _accessor.GetUserId();
        var data = ObjectMapper.Map<CreateDeviceTemplate, DeviceTemplate>(deviceTemplate);

        data.UserId = userId;

        data = await _deviceTemplateRepository.InsertAsync(data);
    }

    /// <inheritdoc />
    public async Task DeleteAsync(Guid id)
    {
        var userId = _accessor.GetUserId();

        await _deviceTemplateRepository.DeleteAsync(x => userId == userId && x.Id == id);
    }

    /// <inheritdoc />
    public async Task<PagedResultDto<DeviceTemplateDto>> GetListAsync(GetDeviceTemplateInput input)
    {
        var userId = _accessor.GetUserId();

        var data = await _deviceTemplateRepository.GetListAsync(input.Keywords, userId, input.StartTime, input.EndTime,
            input.SkipCount, input.MaxResultCount);

        var count = await _deviceTemplateRepository.GetCountAsync(input.Keywords, userId, input.StartTime,
            input.EndTime);

        var dto = ObjectMapper.Map<List<DeviceTemplate>, List<DeviceTemplateDto>>(data);

        return new PagedResultDto<DeviceTemplateDto>(count, dto);
    }

    /// <inheritdoc />
    public async Task UpdateAsync(DeviceTemplateDto dto)
    {
        var data = ObjectMapper.Map<DeviceTemplateDto, DeviceTemplate>(dto);

        await _deviceTemplateRepository.UpdateAsync(data);
    }

    /// <inheritdoc />
    public async Task<List<DeviceTemplateDto>> GetDeviceAllAsync(string keywords)
    {
        var result =
            await _deviceTemplateRepository.GetListAsync(x =>
                string.IsNullOrEmpty(keywords) || x.Name.Contains(keywords));

        var dto = ObjectMapper.Map<List<DeviceTemplate>, List<DeviceTemplateDto>>(result);

        return dto;
    }
}