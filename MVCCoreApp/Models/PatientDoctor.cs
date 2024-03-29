﻿namespace MVCCoreApp.Models
{
    public class PatientDoctor
    {

        //many to many relation
        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
    }
}
