using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackToTeams;
public class SlackContracts
{
}

// Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
public class Attachment
{
    public int id { get; set; }
    public List<Block> blocks { get; set; }
    public string color { get; set; }
    public string fallback { get; set; }
    public string bot_id { get; set; }
    public string app_unfurl_url { get; set; }
    public bool is_app_unfurl { get; set; }
    public string app_id { get; set; }
    public string from_url { get; set; }
    public string thumb_url { get; set; }
    public int? thumb_width { get; set; }
    public int? thumb_height { get; set; }
    public string service_icon { get; set; }
    public string original_url { get; set; }
    public string text { get; set; }
    public string title { get; set; }
    public string title_link { get; set; }
    public string service_name { get; set; }
    public string footer_icon { get; set; }
    public int? ts { get; set; }
    public string footer { get; set; }
    public List<string> mrkdwn_in { get; set; }
}

public class Block
{
    public string type { get; set; }
    public string block_id { get; set; }
    public List<Element> elements { get; set; }
    public Text text { get; set; }
}

public class Edited
{
    public string user { get; set; }
    public string ts { get; set; }
}

public class Element
{
    public string type { get; set; }
    public List<Element> elements { get; set; }
    public object text { get; set; }
    public string user_id { get; set; }
    public string channel_id { get; set; }
    public string url { get; set; }
    public string name { get; set; }
    public string unicode { get; set; }
    public object style { get; set; }
    public bool verbatim { get; set; }
    public string action_id { get; set; }
    public Placeholder placeholder { get; set; }
    public List<Option> options { get; set; }
    public string image_url { get; set; }
    public string alt_text { get; set; }
    public string value { get; set; }
}

public class File
{
    public string id { get; set; }
    public int created { get; set; }
    public int timestamp { get; set; }
    public string name { get; set; }
    public string title { get; set; }
    public string mimetype { get; set; }
    public string filetype { get; set; }
    public string pretty_type { get; set; }
    public string user { get; set; }
    public string user_team { get; set; }
    public bool editable { get; set; }
    public int size { get; set; }
    public string mode { get; set; }
    public bool is_external { get; set; }
    public string external_type { get; set; }
    public bool is_public { get; set; }
    public bool public_url_shared { get; set; }
    public bool display_as_bot { get; set; }
    public string username { get; set; }
    public string url_private { get; set; }
    public string url_private_download { get; set; }
    public string media_display_type { get; set; }
    public string thumb_64 { get; set; }
    public string thumb_80 { get; set; }
    public string thumb_360 { get; set; }
    public int thumb_360_w { get; set; }
    public int thumb_360_h { get; set; }
    public string thumb_480 { get; set; }
    public int thumb_480_w { get; set; }
    public int thumb_480_h { get; set; }
    public string thumb_160 { get; set; }
    public string thumb_720 { get; set; }
    public int thumb_720_w { get; set; }
    public int thumb_720_h { get; set; }
    public string thumb_800 { get; set; }
    public int thumb_800_w { get; set; }
    public int thumb_800_h { get; set; }
    public string thumb_960 { get; set; }
    public int thumb_960_w { get; set; }
    public int thumb_960_h { get; set; }
    public string thumb_1024 { get; set; }
    public int thumb_1024_w { get; set; }
    public int thumb_1024_h { get; set; }
    public int original_w { get; set; }
    public int original_h { get; set; }
    public string thumb_tiny { get; set; }
    public string permalink { get; set; }
    public string permalink_public { get; set; }
    public bool is_starred { get; set; }
    public bool has_rich_preview { get; set; }
    public string file_access { get; set; }
}

public class Option
{
    public Text text { get; set; }
    public string value { get; set; }
}

public class Placeholder
{
    public string type { get; set; }
    public string text { get; set; }
    public bool emoji { get; set; }
}

public class Reaction
{
    public string name { get; set; }
    public List<string> users { get; set; }
    public int count { get; set; }
}

public class Reply
{
    public string user { get; set; }
    public string ts { get; set; }
}

public class Root
{
    public string client_msg_id { get; set; }
    public string type { get; set; }
    public string text { get; set; }
    public string user { get; set; }
    public string ts { get; set; }
    public List<Block> blocks { get; set; }
    public string team { get; set; }
    public string user_team { get; set; }
    public string source_team { get; set; }
    public UserProfile user_profile { get; set; }
    public List<File> files { get; set; }
    public bool? upload { get; set; }
    public bool? display_as_bot { get; set; }
    public List<Reaction> reactions { get; set; }
    public Edited edited { get; set; }
    public string thread_ts { get; set; }
    public int? reply_count { get; set; }
    public int? reply_users_count { get; set; }
    public string latest_reply { get; set; }
    public List<string> reply_users { get; set; }
    public List<Reply> replies { get; set; }
    public bool? is_locked { get; set; }
    public bool? subscribed { get; set; }
    public string parent_user_id { get; set; }
    //public List<Attachment> attachments { get; set; }
}

public class Style
{
    public bool code { get; set; }
}

public class Text
{
    public string type { get; set; }
    public string text { get; set; }
    public bool verbatim { get; set; }
    public bool emoji { get; set; }
}

public class UserProfile
{
    public string avatar_hash { get; set; }
    public string image_72 { get; set; }
    public string first_name { get; set; }
    public string real_name { get; set; }
    public string display_name { get; set; }
    public string team { get; set; }
    public string name { get; set; }
    public bool is_restricted { get; set; }
    public bool is_ultra_restricted { get; set; }
}


