﻿using System;

namespace Assets.SensorFactory
{
    public class ZWaveSensor : SensorHandler
    {
        public ZWaveSensor(SensorData data) : base(data)
        {
        }

        public override string getTextOutput()
        {
            string body = ToString();
            return body.Remove(body.Length - data.value.Length - 7);
        }
    }
    public class ZWaveSensorFactory : SensorDataFactory
    {

        public override SensorHandler SensorFactory()
        {
            return new DefaultSensor(data);
        }
    }



}
