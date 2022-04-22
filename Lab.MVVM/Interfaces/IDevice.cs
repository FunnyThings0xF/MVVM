using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.MVVM.Interfaces
{
    public interface IApplication 
    {
        string Name { get; set; }
        string Category { get; set; }
        long Size { get; set; }
        void Use();
        void Open();
    }   
    public interface IDeviceProperty
    {
        string Name { get; set; }
        string Description { get; set; }
        object Value { get; set; }

        void TrySet(object value);
        object TryGet();
    }
    public interface IDevice
    {
        Guid Guid { get; }
        string Name { get; }
        string Description { get; }
    }
    public interface IPhone : IDevice
    {   
        string Cover { get; set; }
        int LifeStatus { get; set; }
        void Use();
    
        void Install(IApplication application);
        void Remove(IApplication application);

        void SetProperty(IDeviceProperty property);
        IDeviceProperty GetProperty();
    }
}
