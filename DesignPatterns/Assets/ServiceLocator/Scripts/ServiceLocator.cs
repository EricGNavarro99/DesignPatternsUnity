﻿using System;
using System.Collections.Generic;
using UnityEngine.Assertions;

namespace Unity.ServiceLocator
{
    public class ServiceLocator
    {
        public static ServiceLocator Instance => instance ?? (instance = new ServiceLocator());
        private static ServiceLocator instance;

        private Dictionary<Type, object> services;

        public ServiceLocator() => this.services = new Dictionary<Type, object>();

        public void RegisterService<T>(T service) 
        {
            var type = typeof(T);
            Assert.IsFalse(this.services.ContainsKey(type), $"Service {type} already registered.");

            this.services.Add(type, service);
        }

        public T GetService<T>()
        {
            var type = typeof(T);

            if (!this.services.TryGetValue(type, out var service))
                throw new Exception($"Service {type} not found.");

            return (T) service;
        }
    }
}
