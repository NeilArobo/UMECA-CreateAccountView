﻿using System.Collections.ObjectModel;

namespace UM_Consultation_App_MAUI.ViewModels
{
    public class Request
    {
        public int Code { get; set; }
        public string Course { get; set; }
        public string Instructor { get; set; }
    }
    public class RequestViewModel
    {
        public ObservableCollection<Request> Requests { get; set; }

        public RequestViewModel()
        {
            Requests = new ObservableCollection<Request>
            {
                new Request { Code = 6010, Course = "UGE 2", Instructor = "Juan Dela Cruz" },
                new Request { Code = 9193, Course = "CEE 104", Instructor = "Mark Anthony" },
                new Request { Code = 1010, Course = "CPE 101", Instructor = "Nate Smog" },
                new Request { Code = 1010, Course = "PAHF 4", Instructor = "Eva Adam" }
            };

        }
    }
}
