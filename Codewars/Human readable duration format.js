// Human readable duration format
// https://www.codewars.com/kata/human-readable-duration-format/
// by Equim on 16-12-16

function formatDuration (seconds)
{
    if (seconds == 0) return "now";
    
    var sec = seconds % 60 + " second";
    var min = parseInt(seconds / 60 % 60) + " minute";
    var hour = parseInt(seconds / 60 / 60 % 24) + " hour";
    var day = parseInt(seconds / 60 / 60 / 24 % 365) + " day";
    var year = Math.floor(seconds / 60 / 60 / 24 / 365) + " year";
    
    var dur = [year, day, hour, min, sec];
    var rtn = "";
    
    for (var item in dur)
    {
        if (parseInt(dur[item]) > 0)
        {
            if (parseInt(dur[item]) >= 2)
                dur[item] += "s";
            rtn += dur[item] + ", ";
        }
        else
            dur[item] = "";
    }
    
    rtn = rtn.substring(0, rtn.lastIndexOf(", "));
    if (rtn.lastIndexOf(", ") > 0)
        rtn = rtn.substring(0, rtn.lastIndexOf(", ")) + " and " + rtn.substring(rtn.lastIndexOf(", ") + 2);
    
    return rtn;
}
