using NzbDrone.Common.Messaging;
using NzbDrone.Core.Tv;

namespace NzbDrone.Core.MediaFiles.Events
{
    public class EpisodeFileDeletedEvent : IEvent
    {
        public EpisodeFile EpisodeFile { get; private set; }
        public Series Series { get; private set; }
        public DeleteMediaFileReason Reason { get; private set; }

        public EpisodeFileDeletedEvent(EpisodeFile episodeFile, DeleteMediaFileReason reason)
        {
            EpisodeFile = episodeFile;
            Reason = reason;
        }
        public EpisodeFileDeletedEvent(Series series, DeleteMediaFileReason reason)
        {
            Series = series;
            Reason = reason;
        }
    }
}