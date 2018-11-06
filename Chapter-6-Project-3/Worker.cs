using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Project_3
{
    class Worker
    {
        public string CurrentJob { get; private set; }
        public int ShiftNumber { get; private set; }

        private string[] JobsICanDo { get; set; }
        public string[] GetJobsICanDo()
        {
            return JobsICanDo;
        }

        public int GetNumberJobsICanDo()
        {
            return JobsICanDo.Length;
        }

        public int ShiftsForThisJob { get; private set; }

        public Worker(string[] jobsList)
        {
            this.JobsICanDo = jobsList;
        }

        public void DoThisJob(string job, int shifts)
        {
            CurrentJob = job;
            ShiftsForThisJob = shifts;
            ShiftNumber = 0;
        }

        public bool WorkAShift()
        {
            ShiftNumber++;
            if (ShiftNumber == ShiftsForThisJob)
            {
                CurrentJob = "";
                return true;
            }
            return false;
        }
    }
}
