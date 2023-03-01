using System.Collections.Generic;

namespace Aircompany.Planes
{
    public abstract class Plane
    {
        public string _model;
        public int _maxSpeed;
        public int _maxFlightDistance;
        public int _maxLoadCapacity;

        public Plane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity)
        {
            _model = model;
            _maxSpeed = maxSpeed;
            _maxFlightDistance = maxFlightDistance;
            _maxLoadCapacity = maxLoadCapacity;
        }

        public string GetModel()
        {
            return _model;
        }

        public int GetMaxSpeed()
        {
            return _maxSpeed;
        }

        public int GetMaxFlightDistance()
        {
            return _maxFlightDistance;
        }

        public int GetMaxLoadCapacity()
        {
            return _maxLoadCapacity;
        }

        public override string ToString()
        {
            return "Plane{" + "model='" + _model + '\'' + ", maxSpeed=" + _maxSpeed + ", maxFlightDistance=" + _maxFlightDistance + ", maxLoadCapacity=" + _maxLoadCapacity + '}';
        }

        public override bool Equals(object obj)
        {
            var plane = obj as Plane;
            return plane != null && _model == plane._model && _maxSpeed == plane._maxSpeed && _maxFlightDistance == plane._maxFlightDistance && _maxLoadCapacity == plane._maxLoadCapacity;
        }

        public override int GetHashCode()
        {
            var HashCode = -1043886837;
            var HashCodeNumber = -1521134295;
            HashCode = HashCode * HashCodeNumber + EqualityComparer<string>.Default.GetHashCode(_model);
            HashCode = HashCode * HashCodeNumber + _maxSpeed.GetHashCode();
            HashCode = HashCode * HashCodeNumber + _maxFlightDistance.GetHashCode();
            HashCode = HashCode * HashCodeNumber + _maxLoadCapacity.GetHashCode();
            return HashCode;
        }
    }
}