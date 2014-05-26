﻿#region Copyright (C) 2005-2011 Team MediaPortal

// Copyright (C) 2005-2011 Team MediaPortal
// http://www.team-mediaportal.com
// 
// MediaPortal is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// MediaPortal is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with MediaPortal. If not, see <http://www.gnu.org/licenses/>.

#endregion

namespace Mediaportal.TV.Server.TVLibrary.Interfaces.Interfaces
{
  /// <summary>
  /// An interface to be implemented by classes that want to be notified
  /// when tuner detection events occur.
  /// </summary>
  public interface ITunerDetectionEventListener
  {
    /// <summary>
    /// This call back is invoked when a tuner is detected.
    /// </summary>
    /// <param name="tuner">The tuner that has been detected.</param>
    void OnTunerAdded(ITVCard tuner);

    /// <summary>
    /// This call back is invoked when a tuner is removed.
    /// </summary>
    /// <param name="tuner">The tuner that has been removed.</param>
    void OnTunerRemoved(ITVCard tuner);
  }
}