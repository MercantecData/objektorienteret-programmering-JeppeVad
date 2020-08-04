using System;
using System.Collections.Generic;
using System.Text;

namespace Personregister
{
    public class Job
    {
        public string firm;
        public string jobTitle;
        public int salary;

        public Job(string jobTitle, int salary, string firm)
        {
            this.firm = firm;
            this.jobTitle = jobTitle;
            this.salary = salary;
        }
        // Overloader på job, så hvis man ikke angiver sin løn, bliver den sat til 0
        public Job(string firm, string jobTitle)
        {
            this.firm = firm;
            this.jobTitle = jobTitle;
            salary = 0;
        }
        // Overloader på job, så hvis hvis man ikke angiver sit firma, sætter den det til "UNKNOWN"
        public Job(string jobTitle, int salary)
        {
            this.jobTitle = jobTitle;
            firm = "UNKNOWN";
            this.salary = salary;
        }

    }
}
