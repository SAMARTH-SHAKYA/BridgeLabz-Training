using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.HospitalManagement
{
    internal class InPatient : Patient
    {
        public int RoomNumber { get; set; }
        public int DaysAdmitted { get; set; }

        public InPatient(string name, int age,string healthCardNumber) : base(name,age,healthCardNumber)
        {
            //this.RoomNumber = roomNumber;
            //this.DaysAdmitted = daysAdmitted;
        }

        public void SetRoomNumber(int roomNumberByReception)
        {
            RoomNumber = roomNumberByReception;
        }

        public void CheckDaysAdmitted(int daysAdmittedByReception)
        {
            DaysAdmitted = daysAdmittedByReception;
        }

        public object ReadyToCheckout()
        {
            return this;
        }

    }
}
