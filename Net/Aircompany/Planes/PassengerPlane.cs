﻿using System;

namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {
        private int _passengersCapacity;
        public PassengerPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, int passengersCapacity)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            _passengersCapacity = passengersCapacity;
        }

        public override bool Equals(object obj)
        {
            var plane = obj as PassengerPlane;
            return plane != null && base.Equals(obj) && _passengersCapacity == plane._passengersCapacity;
        }

        public override int GetHashCode()
        {
            int HashCode = 751774561;
            hashCode = hashCode * HashCodeNumber + base.GetHashCode();
            hashCode = hashCode * HashCodeNumber + _passengersCapacity.GetHashCode();
            return hashCode;
        }

        public int GetPassengersCapacity()
        {
            return _passengersCapacity;
        }

        public override string ToString()
        {
            return base.ToString().Replace("}", $", passengersCapacity= {_passengersCapacity} }}");
        }
    }
}