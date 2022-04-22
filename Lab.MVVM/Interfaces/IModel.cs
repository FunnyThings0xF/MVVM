using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.MVVM.Interfaces
{
    public interface IDeviceModel
    {
        void Add(IDevice device);
        IDevice GetDevice(Guid id);
        void Remove(IDevice device);

        void InstallProperty(IDeviceProperty property); 
        void RemoveProperty(IDeviceProperty property);
        IEnumerable<IDeviceProperty> GetAllProperties();
    }
}
