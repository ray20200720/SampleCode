using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSample
{
    public class ShipmentDeliveryPalletInfo
    {
        public int CartonQty;
        public int CombineCartonQty;
        public int CombineDeviceQty;
        public string DeliveryNo;
        public int DeviceQty;
        public string Model;
        public string PalletNo;
        public string ShipmentNo;
        public decimal TotalCartonWeight;
        public decimal TotalUnitWeight;

        //public ShipmentDeliveryPalletInfo(string shipmentNo, string palletNo)
        //{
        //    ShipmentNo = shipmentNo;
        //    PalletNo = palletNo;
        //}
    }
}
