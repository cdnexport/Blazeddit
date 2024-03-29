﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Blazeddit.Shared.Response.PostR
{
    public partial class PostResponse : IJsonSerializable<PostResponse>
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("data")]
        public PostResponseData Data { get; set; }

        public PostResponse[] JsonArr(string from) => PostResponse.FromJson(from);

        public PostResponse Json(string from) => throw new PlatformNotSupportedException("improper function to serialize");
    }

    public partial class PostResponseData
    {
        [JsonProperty("modhash")]
        public string Modhash { get; set; }

        [JsonProperty("dist")]
        public long? Dist { get; set; }

        [JsonProperty("children")]
        public Child[] Children { get; set; }

        [JsonProperty("after")]
        public object After { get; set; }

        [JsonProperty("before")]
        public object Before { get; set; }
    }

    public partial class Child
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("data")]
        public DataElement Data { get; set; }
    }

    public partial class DataElement
    {
        [JsonProperty("approved_at_utc")]
        public object ApprovedAtUtc { get; set; }

        [JsonProperty("subreddit")]
        public string Subreddit { get; set; }

        [JsonProperty("selftext", NullValueHandling = NullValueHandling.Ignore)]
        public string Selftext { get; set; }

        [JsonProperty("user_reports")]
        public object[] UserReports { get; set; }

        [JsonProperty("saved")]
        public bool Saved { get; set; }

        [JsonProperty("mod_reason_title")]
        public object ModReasonTitle { get; set; }

        [JsonProperty("gilded")]
        public long Gilded { get; set; }

        [JsonProperty("clicked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clicked { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("link_flair_richtext", NullValueHandling = NullValueHandling.Ignore)]
        public LinkFlairRichtext[] LinkFlairRichtext { get; set; }

        [JsonProperty("subreddit_name_prefixed")]
        public string SubredditNamePrefixed { get; set; }

        [JsonProperty("hidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidden { get; set; }

        [JsonProperty("pwls")]
        public long? Pwls { get; set; }

        [JsonProperty("link_flair_css_class")]
        public string LinkFlairCssClass { get; set; }

        [JsonProperty("downs")]
        public long Downs { get; set; }

        [JsonProperty("thumbnail_height", NullValueHandling = NullValueHandling.Ignore)]
        public long? ThumbnailHeight { get; set; }

        [JsonProperty("parent_whitelist_status")]
        public string ParentWhitelistStatus { get; set; }

        [JsonProperty("hide_score", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideScore { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quarantine", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Quarantine { get; set; }

        [JsonProperty("link_flair_text_color", NullValueHandling = NullValueHandling.Ignore)]
        public string LinkFlairTextColor { get; set; }

        [JsonProperty("upvote_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public double? UpvoteRatio { get; set; }

        [JsonProperty("author_flair_background_color")]
        public object AuthorFlairBackgroundColor { get; set; }

        [JsonProperty("subreddit_type")]
        public string SubredditType { get; set; }

        [JsonProperty("ups")]
        public long Ups { get; set; }

        [JsonProperty("total_awards_received")]
        public long TotalAwardsReceived { get; set; }

        [JsonProperty("media_embed", NullValueHandling = NullValueHandling.Ignore)]
        public Gildings MediaEmbed { get; set; }

        [JsonProperty("thumbnail_width", NullValueHandling = NullValueHandling.Ignore)]
        public long? ThumbnailWidth { get; set; }

        [JsonProperty("author_flair_template_id")]
        public object AuthorFlairTemplateId { get; set; }

        [JsonProperty("is_original_content", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOriginalContent { get; set; }

        [JsonProperty("author_fullname")]
        public string AuthorFullname { get; set; }

        [JsonProperty("secure_media")]
        public object SecureMedia { get; set; }

        [JsonProperty("is_reddit_media_domain", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRedditMediaDomain { get; set; }

        [JsonProperty("is_meta", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMeta { get; set; }

        [JsonProperty("category")]
        public object Category { get; set; }

        [JsonProperty("num_comments", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumComments { get; set; }

        [JsonProperty("secure_media_embed", NullValueHandling = NullValueHandling.Ignore)]
        public Gildings SecureMediaEmbed { get; set; }

        [JsonProperty("link_flair_text")]
        public string LinkFlairText { get; set; }

        [JsonProperty("can_mod_post")]
        public bool CanModPost { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("approved_by")]
        public object ApprovedBy { get; set; }

        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Thumbnail { get; set; }

        [JsonProperty("edited")]
        public bool Edited { get; set; }

        [JsonProperty("author_flair_css_class")]
        public object AuthorFlairCssClass { get; set; }

        [JsonProperty("author_flair_richtext")]
        public object[] AuthorFlairRichtext { get; set; }

        [JsonProperty("gildings")]
        public Gildings Gildings { get; set; }

        [JsonProperty("post_hint", NullValueHandling = NullValueHandling.Ignore)]
        public string PostHint { get; set; }

        [JsonProperty("content_categories")]
        public object ContentCategories { get; set; }

        [JsonProperty("is_self", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSelf { get; set; }

        [JsonProperty("mod_note")]
        public object ModNote { get; set; }

        [JsonProperty("crosspost_parent_list", NullValueHandling = NullValueHandling.Ignore)]
        public DataElement[] CrosspostParentList { get; set; }

        [JsonProperty("created")]
        public long Created { get; set; }

        [JsonProperty("link_flair_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LinkFlairType { get; set; }

        [JsonProperty("wls")]
        public long? Wls { get; set; }

        [JsonProperty("banned_by")]
        public object BannedBy { get; set; }

        [JsonProperty("author_flair_type")]
        public string AuthorFlairType { get; set; }

        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        [JsonProperty("selftext_html")]
        public object SelftextHtml { get; set; }

        [JsonProperty("likes")]
        public object Likes { get; set; }

        [JsonProperty("suggested_sort")]
        public object SuggestedSort { get; set; }

        [JsonProperty("banned_at_utc")]
        public object BannedAtUtc { get; set; }

        [JsonProperty("view_count")]
        public object ViewCount { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("no_follow")]
        public bool NoFollow { get; set; }

        [JsonProperty("is_crosspostable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCrosspostable { get; set; }

        [JsonProperty("pinned", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Pinned { get; set; }

        [JsonProperty("over_18", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Over18 { get; set; }

        [JsonProperty("preview", NullValueHandling = NullValueHandling.Ignore)]
        public Preview Preview { get; set; }

        [JsonProperty("all_awardings")]
        public object[] AllAwardings { get; set; }

        [JsonProperty("media_only", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MediaOnly { get; set; }

        [JsonProperty("link_flair_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? LinkFlairTemplateId { get; set; }

        [JsonProperty("can_gild")]
        public bool CanGild { get; set; }

        [JsonProperty("spoiler", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Spoiler { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("author_flair_text")]
        public object AuthorFlairText { get; set; }

        [JsonProperty("visited", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visited { get; set; }

        [JsonProperty("num_reports")]
        public object NumReports { get; set; }

        [JsonProperty("distinguished")]
        public object Distinguished { get; set; }

        [JsonProperty("subreddit_id")]
        public string SubredditId { get; set; }

        [JsonProperty("mod_reason_by")]
        public object ModReasonBy { get; set; }

        [JsonProperty("removal_reason")]
        public object RemovalReason { get; set; }

        [JsonProperty("link_flair_background_color", NullValueHandling = NullValueHandling.Ignore)]
        public string LinkFlairBackgroundColor { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_robot_indexable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRobotIndexable { get; set; }

        [JsonProperty("stickied")]
        public bool Stickied { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("num_crossposts", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumCrossposts { get; set; }

        [JsonProperty("media")]
        public object Media { get; set; }

        [JsonProperty("send_replies")]
        public bool SendReplies { get; set; }

        [JsonProperty("contest_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContestMode { get; set; }

        [JsonProperty("author_patreon_flair")]
        public bool AuthorPatreonFlair { get; set; }

        [JsonProperty("crosspost_parent", NullValueHandling = NullValueHandling.Ignore)]
        public string CrosspostParent { get; set; }

        [JsonProperty("author_flair_text_color")]
        public object AuthorFlairTextColor { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("whitelist_status")]
        public string WhitelistStatus { get; set; }

        [JsonProperty("report_reasons")]
        public object ReportReasons { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("subreddit_subscribers", NullValueHandling = NullValueHandling.Ignore)]
        public long? SubredditSubscribers { get; set; }

        [JsonProperty("created_utc")]
        public long CreatedUtc { get; set; }

        [JsonProperty("mod_reports")]
        public object[] ModReports { get; set; }

        [JsonProperty("is_video", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVideo { get; set; }

        [JsonProperty("link_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LinkId { get; set; }

        [JsonProperty("replies", NullValueHandling = NullValueHandling.Ignore)]
        public string Replies { get; set; }

        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        [JsonProperty("is_submitter", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSubmitter { get; set; }

        [JsonProperty("collapsed_reason")]
        public object CollapsedReason { get; set; }

        [JsonProperty("body_html", NullValueHandling = NullValueHandling.Ignore)]
        public string BodyHtml { get; set; }

        [JsonProperty("score_hidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ScoreHidden { get; set; }

        [JsonProperty("collapsed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Collapsed { get; set; }

        [JsonProperty("controversiality", NullValueHandling = NullValueHandling.Ignore)]
        public long? Controversiality { get; set; }

        [JsonProperty("depth", NullValueHandling = NullValueHandling.Ignore)]
        public long? Depth { get; set; }
    }

    public partial class Gildings
    {
    }

    public partial class LinkFlairRichtext
    {
        [JsonProperty("e")]
        public string E { get; set; }

        [JsonProperty("t")]
        public string T { get; set; }
    }

    public partial class Preview
    {
        [JsonProperty("images")]
        public Image[] Images { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("resolutions")]
        public Source[] Resolutions { get; set; }

        [JsonProperty("variants")]
        public Gildings Variants { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public partial class Source
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }

    public partial class PostResponse
    {
        public static PostResponse[] FromJson(string json) => JsonConvert.DeserializeObject<PostResponse[]>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this PostResponse[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
        {
            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
        },
        };
    }
}
