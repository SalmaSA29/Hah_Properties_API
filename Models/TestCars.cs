using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TestCars
    {
        public TestCars()
        {
            TestEmpD = new HashSet<TestEmpD>();
        }

        public string TestId { get; set; }
        public string TestName { get; set; }
        public string TestModel { get; set; }
        public string TestMotor { get; set; }
        public byte? TestType { get; set; }
        public bool? TestCluck { get; set; }
        public bool? TestAlarm { get; set; }
        public bool? TestAirCar { get; set; }

        public virtual ICollection<TestEmpD> TestEmpD { get; set; }
    }
}
