using System;

namespace Job
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
    }
}
