﻿using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        private MilitaryType _type;

        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, MilitaryType type)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            _type = type;
        }

        public override bool Equals(object obj)
        {
            var plane = obj as MilitaryPlane;
            return plane != null && base.Equals(obj) && _type == plane._type;
        }

        public override int GetHashCode()
        {
            int hashCode = 1701194404;
            hashCode = hashCode * HashCodeNumber + base.GetHashCode();
            hashCode = hashCode * HashCodeNumber + _type.GetHashCode();
            return hashCode;
        }

        public MilitaryType GetPlaneType()
        {
            return _type;
        }

        public override string ToString()
        {
            return base.ToString().Replace("}", ", type=" + _type + '}');
        }
    }
}