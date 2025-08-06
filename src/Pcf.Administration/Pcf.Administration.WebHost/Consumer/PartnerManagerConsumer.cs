using MassTransit;
using Microsoft.AspNetCore.Mvc.Formatters;
using Pcf.Administration.Core.Abstractions.Repositories;
using Pcf.Administration.Core.Domain.Administration;
using Pcf.Administration.WebHost.Service;
using Pcf.ReceivingFromPartner.Integration.Dto;
using System.Threading.Tasks;

namespace Pcf.RabbitMQ.Consumer
{
    public class PartnerManagerConsumer : IConsumer<NotifyAdminAboutPartnerManagerDto>
    {
        public PartnerManagerConsumer(IRepository<Employee> _employeeRepository) 
        { 

        }
        public Task Consume(ConsumeContext<NotifyAdminAboutPartnerManagerDto> context)
        {
            var message = context.Message;

            //if (await EmployeeService.UpdateAppliedPromocodesAsync(_employeeRepository, id))

            return context.RespondAsync(message);
        }
    }
}
