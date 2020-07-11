﻿using System;

namespace TalentExchange.Services
{
    public class ServiceResponse<T>
    {
        public bool IsSuccess { get; set; }
        public String Message { get; set; }
        public DateTime Time { get; set; }
        public T Data { get; set; }
    }
}
