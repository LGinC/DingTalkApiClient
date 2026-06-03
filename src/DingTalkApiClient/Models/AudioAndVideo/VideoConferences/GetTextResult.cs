using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.AudioAndVideo.VideoConferences;

/// <summary>
/// 
/// </summary>
public class GetTextResult
{
    /// <summary>
    /// 是否还有更多段落（用于分页）
    /// </summary>
    public bool HasMore { get; set; }

    /// <summary>
    /// 段落列表（每个段落包含句子、单词信息）
    /// </summary>
    public List<Paragraph> ParagraphList { get; set; } = [];
}

/// <summary>
/// 语音转文字的段落信息
/// </summary>
public class Paragraph
{
    /// <summary>
    /// 下一页分页令牌
    /// </summary>
    public long NextTtoken { get; set; }

    /// <summary>
    /// 段落状态 该字段暂无使用场景。
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// 发言人的unionId
    /// </summary>
    public required string UnionId { get; set; }

    /// <summary>
    /// 发言人昵称
    /// </summary>
    public required string NickName { get; set; }

    /// <summary>
    /// 录制ID
    /// </summary>
    public long RecordId { get; set; }

    /// <summary>
    /// 段落开始时间（毫秒，相对于录音起始点）
    /// </summary>
    public long StartTime { get; set; }

    /// <summary>
    /// 段落结束时间（毫秒，相对于录音起始点）
    /// </summary>
    public long EndTime { get; set; }

    /// <summary>
    /// 段落文本内容
    /// </summary>
    [JsonPropertyName("paragraph")]
    public string? ParagraphText { get; set; }

    /// <summary>
    /// 段落内的句子列表
    /// </summary>
    public List<Sentence> SentenceList { get; set; } = [];
}

/// <summary>
/// 段落内的句子信息
/// </summary>
public class Sentence
{
    /// <summary>
    /// 用户的unionId
    /// </summary>
    public required string UnionId { get; set; }

    /// <summary>
    /// 句子文本内容
    /// </summary>
    [JsonPropertyName("Sentence")]
    public string? SentenceText { get; set; }

    /// <summary>
    /// 句子开始时间（毫秒）
    /// </summary>
    public long StartTime { get; set; }

    /// <summary>
    /// 句子结束时间（毫秒）
    /// </summary>
    public long EndTime { get; set; }

    /// <summary>
    /// 句子内的单词列表
    /// </summary>
    public List<Word> WordList { get; set; } = [];
}

/// <summary>
/// 句子内的单词信息
/// </summary>
public class Word
{
    /// <summary>
    /// 单词文本
    /// </summary>
    [JsonPropertyName("word")]
    public string? WordText { get; set; }

    /// <summary>
    /// 单词开始时间（毫秒）
    /// </summary>
    public long StartTime { get; set; }

    /// <summary>
    /// 单词结束时间（毫秒）
    /// </summary>
    public long EndTime { get; set; }

    /// <summary>
    /// 单词唯一标识
    /// </summary>
    public string? WordId { get; set; }
}