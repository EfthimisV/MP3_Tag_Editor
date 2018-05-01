using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3_Tag_Editor
{
    public class DiscogsResponse
    {
        public Pagination pagination { get; set; }
        public Result[] results { get; set; }
    }

    public class Pagination
    {
        public int per_page { get; set; }
        public int pages { get; set; }
        public int page { get; set; }
        public Urls urls { get; set; }
        public int items { get; set; }
    }

    public class Urls
    {
        public string last { get; set; }
        public string next { get; set; }
    }

    public class Result
    {
        /// <summary>
        ///    Gets the music style for the searched album from Discogs.
        /// </summary>
        public string[] style { get; set; }
        /// <summary>
        ///    Gets the thumbnail picture for the album that the song belongs to from Discogs.
        /// </summary>
        public string thumb { get; set; }
        /// <summary>
        ///    Gets the type the media that the song was distributed to from Discogs.
        /// </summary>
        public string[] format { get; set; }
        /// <summary>
        ///    Gets the song's country of origin from Discogs.
        /// </summary>
        public string country { get; set; }
        public string[] barcode { get; set; }
        public string uri { get; set; }
        public Community community { get; set; }
        public string[] label { get; set; }
        public string[] genre { get; set; }
        public string catno { get; set; }
        public string year { get; set; }
        /// <summary>
        ///    Gets the URL for the cover image of the album that the song belongs to from Discogs.
        /// </summary>
        public string cover_image { get; set; }
        public string title { get; set; }
        public string resource_url { get; set; }
        public string type { get; set; }
        public int id { get; set; }
    }

    public class Community
    {
        public int want { get; set; }
        public int have { get; set; }
    }
}
