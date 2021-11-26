using WebApp.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Areas.Users.Models;
using WebApp.Areas.Patient.Models;
using WebApp.Areas.Doctor.Models;

namespace WebApp.Areas.Admin.Controllers
{
    public class AppRepository
    {
       //public Dictionary<int, string> TimeRanges = new Dictionary<int, string>()
       // {
       //     [1] = "07:00-08:00",
       //     [2]="08:00-09:00",
       //     [3]="09:00-10:00",
       //     [4]="10:00-11:00",
       //     [5]="13:30-14:30",
       //     [6]="14:30-15:30",
       //     [7] = "15:30-16:30"
       // };
        DepartmentRepository department;
        RoomRepository room;
        MeGroupRepository megroup;
        MeElementRepository meelement;        
        EducationRepository education;        
        DVHCRepository dVHC;
        ProducerRepository producer;
        TimeRangeRepository timeRange;
        SesRepository ses;
        EmployeeRepository employee;
        MedicineRepository medicine;
        RoleRepository role;
        EmailRepository email;
        OTPRepository otp;
        ScheduleRepository schedule;
        PatientsRepository patient;
        JobRepository job;
        PKBRepository pkb;
        PrecriptionReponsitory precription;
        DetailPreReponsitory detailpre;
        DetailTransactionRepository detailTransaction;

        public DetailTransactionRepository DetailTransaction
        {
            get
            {
                if (detailTransaction is null)
                {
                    detailTransaction = new DetailTransactionRepository();
                }
                return detailTransaction;
            }
        }
        public PrecriptionReponsitory Precription
        {
            get
            {
                if (precription is null)
                {
                    precription = new PrecriptionReponsitory();
                }
                return precription; 
            }
        }
        public DetailPreReponsitory DetailPre
        {
            get
            {
                if (detailpre is null)
                {
                    detailpre = new DetailPreReponsitory();
                }
                return detailpre;
            }
        }
        public PKBRepository PKB
        {
            get
            {
                if (pkb is null)
                {
                    pkb = new PKBRepository();
                }
                return pkb;
            }
        }
        public JobRepository Job
        {
            get
            {
                if (job is null)
                {
                    job = new JobRepository();
                }
                return job;
            }
        }
        public PatientsRepository Patient
        {
            get
            {
                if (patient is null)
                {
                    patient = new PatientsRepository();
                }
                return patient;
            }
        }
        public ScheduleRepository Schedule
        {
            get
            {
                if (schedule is null)
                {
                    schedule = new ScheduleRepository();
                }
                return schedule;
            }
        }
        public OTPRepository OTP
        {
            get
            {
                if (otp is null)
                {
                    otp = new OTPRepository();
                }
                return otp;
            }
        }
        public EmailRepository Email
        {
            get
            {
                if (email is null)
                {
                    email = new EmailRepository();
                }
                return email;
            }
        }
        public RoleRepository Role
        {
            get
            {
                if (role is null)
                {
                    role = new RoleRepository();
                }
                return role;
            }
        }
        public EmployeeRepository Employee
        {
            get
            {
                if (employee is null)
                {
                    employee = new EmployeeRepository();
                }
                return employee;
            }
        }
        public SesRepository Ses
        {
            get
            {
                if (ses is null)
                {
                    ses = new SesRepository();
                }
                return ses;
            }
        }
        public TimeRangeRepository TimeRange
        {
            get
            {
                if (timeRange is null)
                {
                    timeRange = new TimeRangeRepository();
                }
                return timeRange;
            }
        }
        public ProducerRepository Producer
        {
            get
            {
                if (producer is null)
                {
                    producer = new ProducerRepository();
                }
                return producer;
            }
        }
        public DVHCRepository DVHC
        {
            get
            {
                if (dVHC is null)
                {
                    dVHC = new DVHCRepository();
                }
                return dVHC;
            }
        }
        public MeElementRepository MeElement
        {
            get
            {
                if (meelement is null)
                {
                    meelement = new MeElementRepository();
                }
                return meelement;
            }
        }
        public MeGroupRepository Megroup
        {
            get
            {
                if (megroup is null)
                {
                    megroup = new MeGroupRepository();
                }
                return megroup;
            }
        }
        public RoomRepository Room
        {
            get
            {
                if (room is null)
                {
                    room = new RoomRepository();
                }
                return room;
            }
        }
        public DepartmentRepository Department
        {
            get
            {
                if (department is null)
                {
                    department = new DepartmentRepository();
                }
                return department;
            }
        }
        public EducationRepository Education
        {
            get
            {
                if (education is null)
                {
                    education = new EducationRepository();
                }
                return education;
            }
        }
        public MedicineRepository Medicine
        {
            get
            {
                if (medicine is null)
                {
                    medicine = new MedicineRepository();
                }
                return medicine;
            }
        }


    }
}
