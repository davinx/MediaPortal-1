#region Copyright (C) 2005-2011 Team MediaPortal

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

using Mediaportal.TV.Server.TVDatabase.Entities.Enums;
using Mediaportal.TV.Server.TVLibrary.Interfaces.Interfaces;

namespace Mediaportal.TV.Server.TVLibrary.Streaming
{
  /// <summary>
  /// Class describing a single rtsp stream
  /// </summary>
  public class RtspStream
  {
    #region variables

    private readonly string _fileName;
    private readonly string _streamName;
    private readonly ITVCard _card;
    private readonly string _recording;
    private readonly MediaTypeEnum _mediaType;

    #endregion

    #region constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="RtspStream"/> class.
    /// </summary>
    /// <param name="streamName">Name of the stream.</param>
    /// <param name="fileName">Name of the file.</param>
    /// <param name="card">The card.</param>
    /// <param name="mediaType">The type of the stream (eg. video + audio, audio only).</param>
    public RtspStream(string streamName, string fileName, ITVCard card, MediaTypeEnum mediaType)
    {
      _streamName = streamName;
      _fileName = fileName;
      _recording = string.Empty;
      _card = card;
      _mediaType = mediaType;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RtspStream"/> class.
    /// </summary>
    /// <param name="streamName">Name of the stream.</param>
    /// <param name="fileName">Name of the file.</param>
    /// <param name="recording">The recording.</param>
    public RtspStream(string streamName, string fileName, string recording)
    {
      _streamName = streamName;
      _fileName = fileName;
      _recording = recording;
      _card = null;
    }

    #endregion

    #region properties

    /// <summary>
    /// Gets the stream name.
    /// </summary>
    /// <value>The name.</value>
    public string Name
    {
      get { return _streamName; }
    }

    /// <summary>
    /// Gets the name of the file.
    /// </summary>
    /// <value>The name of the file.</value>
    public string FileName
    {
      get { return _fileName; }
    }

    /// <summary>
    /// Gets the recording.
    /// </summary>
    /// <value>The recording.</value>
    public string Recording
    {
      get { return _recording; }
    }

    /// <summary>
    /// Gets the card.
    /// </summary>
    /// <value>The card.</value>
    public ITVCard Card
    {
      get { return _card; }
    }
   

    public MediaTypeEnum MediaType
    {
      get { return _mediaType; }      
    }

    #endregion
  }
}