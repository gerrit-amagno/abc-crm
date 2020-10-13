﻿using System;
using RestSharp.Deserializers;

namespace Abc.Crm.WindowsClient.Models
{
    public class CustomerDocument
    {
        public Guid Id { get; set; }

        public string No { get; set; }

        public string Date { get; set; }

        public string Name { get; set; }

        public string CreateDate { get; set; }

        public byte[] Preview { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}