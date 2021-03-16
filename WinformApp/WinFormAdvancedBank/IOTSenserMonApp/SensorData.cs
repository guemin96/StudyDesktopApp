using System;

namespace IOTSenserMonApp
{
    internal class SensorData
    {
        public DateTime current { get; set; } // 현재 시간
        public int Value { get; set; } // 센서 값

        public bool SimulFlag { get; set; } // 시뮬레이션 여부
        public SensorData(DateTime current, int value, bool simulFlag)
        {
            this.current = current;
            this.Value = value;
            SimulFlag = simulFlag;
        }
    }
}
