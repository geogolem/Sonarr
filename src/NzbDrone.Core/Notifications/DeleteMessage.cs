﻿using System.Collections.Generic;
using NzbDrone.Core.MediaFiles;
using NzbDrone.Core.Tv;

namespace NzbDrone.Core.Notifications
{
    public class DeleteMessage
    {
        public string Message { get; set; }
        public Series Series { get; set; }
        public EpisodeFile EpisodeFile { get; set; }
        //public List<EpisodeFile> OldFiles { get; set; }
        public DeleteMediaFileReason Reason { get; set; }

        public override string ToString()
        {
            return Message;
        }
    }
}