﻿using System;

namespace dokas.FluentStrings.Actions.Remove
{
    public class RemoveStringStarting
    {
        private readonly RemoveString _removeString;
        private readonly int _positionIndex;

        internal RemoveStringStarting(RemoveString removeString, int positionIndex)
        {
            _removeString = removeString;
            _positionIndex = positionIndex;
        }

        public static implicit operator string(RemoveStringStarting removeStringStarting)
        {
            return removeStringStarting.ToString();
        }

        public override string ToString()
        {
            if (_positionIndex < 0)
            {
                throw new ArgumentOutOfRangeException("_positionIndex");
            }

            if (_removeString.Source.IsEmpty() || _positionIndex >= _removeString.Source.Length)
            {
                return _removeString.Source;
            }
            return _removeString.Source.Substring(0, _positionIndex);
        }
    }
}
