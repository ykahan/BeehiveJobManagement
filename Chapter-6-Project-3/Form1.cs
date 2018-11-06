using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_6_Project_3
{
    public partial class Form1 : Form
    {
        private String tutoring = "Baby Bee Tutoring";
        private String eggs = "Egg Care";
        private String hive = "Hive Maintenance";
        private String honey = "Honey Manufacturing";
        private String nectar = "Nectar Collection";
        private String sting = "Sting Patrol";
        private Worker[] workers;
        private String[] jobs;
        private Random rand = new Random();
        private Queen queen;
        private string Message;
        
        public Form1()
        {
            InitializeComponent();

            int numberOfWorkers = rand.Next(4, 10);
            workers = new Worker[numberOfWorkers];
            jobs = new String[] { tutoring, eggs, hive, honey, nectar, sting };
            JobsComboBox.SelectedIndex = 0;

            for (int worker = 0; worker < numberOfWorkers; worker++) TeachJobs(worker);
            DisplayMessage();


            queen = new Queen(workers);
            string queenWorkers = queen.GetWorkers();
            Message += queenWorkers;
            DisplayMessage();
        }

        public void SetMessage(string message)
        {
            this.Message = message;
        }

        void TeachJobs(int indexNumber)
        {
            int numJobs = rand.Next(2, 7);
            String[] jobsList = new String[numJobs];
            for (int job = 0; job < numJobs; job++)
            {
                while (jobsList[job] == null)
                {
                    string jobName = jobs[rand.Next(0, 6)];
                    if (!jobsList.Contains(jobName)) jobsList[job] = jobName;
                }
            }
            workers[indexNumber] = new Worker(jobsList);
            DisplayWorkerAbilities(indexNumber, numJobs, workers, jobsList);
                    }

        private void DisplayWorkerAbilities(int workerNumber, int numJobs, Worker[] workers, string[] jobsList)
        {
            Message += ($"Worker bee #{workerNumber + 1} can do {numJobs} jobs:\r\n");
            for (int jobToDisplay = 0; jobToDisplay < numJobs; jobToDisplay++)
            {
                Message += ($"\t{jobToDisplay + 1}: {workers[workerNumber].GetJobsICanDo()[jobToDisplay]}\r\n");
            }
            Message += "\r\n";
        }

        private void DisplayAssignedJob(int beeNumber, string job, int shifts)
        {
            if (beeNumber >= 0) Message = ($"Worker bee #{beeNumber} has been assigned the job \"{job}\" for {shifts} shifts.");
            else Message = ("The job was not assigned.");
        }
    
        private void DisplayMessage()
        {
            ReportTxtBox.Text = Message;
        }

        private void AssignBtn_Click(object sender, EventArgs e)
        {
            string job = JobsComboBox.Text;
            int shifts = (int)ShiftsNumUpDown.Value;
            int isJobAssigned = queen.AssignWork(job, shifts);
            DisplayAssignedJob(isJobAssigned, job, shifts);
        }

        private void JobsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (JobsComboBox.Text != "") AssignBtn.Enabled = true;
            else AssignBtn.Enabled = false;

        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {

        }
    }
}
