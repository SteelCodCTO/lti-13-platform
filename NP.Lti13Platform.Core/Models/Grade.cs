using NP.Lti13Platform.Core.Interfaces;

namespace NP.Lti13Platform.Core.Models;

/// <summary>
/// Represents a grade associated with a line item and user as defined in the LTI 1.3 Assignment and Grade Services specification.
/// A grade represents a score or evaluation result for a student on a specific line item.
/// </summary>
public class Grade: IGrade
{
    ///// <summary>
    ///// Gets or sets the identifier of the deployment.
    ///// </summary>
    //public required string DeploymentId { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the line item.
    /// References the line item in the gradebook to which this grade belongs.
    /// </summary>
    public required string LineItemId { get; set; }

    /// <summary>
    /// The user to whom this grade applies. This should correspond to a user ID in the platform.
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// The user who created or last modified this grade (typically an instructor or grader).
    /// </summary>
    public string? ScoringUserId { get; set; }

    /// <summary>
    /// The numeric score achieved by the student on the associated line item. This may be scaled by resultMaximum to determine the final grade percentage.
    /// </summary>
    public decimal? ResultScore { get; set; }

    /// <summary>
    /// The maximum possible score value for this result. If not specified, the scoreMaximum from the line item should be used.
    /// </summary>
    public decimal? ResultMaximum { get; set; }

    /// <summary>
    /// Optional instructor feedback or notes related to this grade.
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// The date and time when this grade was created or last modified. As specified by the ISO 8601 format in the LTI specification.
    /// </summary>
    public DateTimeOffset Timestamp { get; set; }

    /// <summary>
    /// The date and time when this grade was or will be released to the student. Can be used for scheduled grade releases.
    /// </summary>
    public DateTimeOffset? ReleaseDateTime { get; set; }

    /// <summary>
    /// Indicates the status of the user's activity associated with this grade. As defined in the LTI Assignment and Grade Services specification.
    /// </summary>
    public ActivityProgress ActivityProgress { get; set; }

    /// <summary>
    /// Indicates the status of the grading process for this grade. As defined in the LTI Assignment and Grade Services specification.
    /// </summary>
    public GradingProgress GradingProgress { get; set; }

    /// <summary>
    /// When the user began working on the activity associated with this grade.
    /// </summary>
    public DateTimeOffset? StartedAt { get; set; }

    /// <summary>
    /// When the user submitted their work for the activity associated with this grade.
    /// </summary>
    public DateTimeOffset? SubmittedAt { get; set; }

    /// <summary>
    /// Creates a strongly-typed clone of the given IGrade instance.
    /// </summary>
    public static Grade Clone(IGrade li)
    {
        return new Grade
        {
            LineItemId = li.LineItemId,
            UserId = li.UserId,
            ScoringUserId = li.ScoringUserId,
            ResultScore = li.ResultScore,
            ResultMaximum = li.ResultMaximum,
            Comment = li.Comment,
            Timestamp = li.Timestamp,
            ReleaseDateTime = li.ReleaseDateTime,
            ActivityProgress = li.ActivityProgress,
            GradingProgress = li.GradingProgress,
            StartedAt = li.StartedAt,
            SubmittedAt = li.SubmittedAt

        };
    }

}

