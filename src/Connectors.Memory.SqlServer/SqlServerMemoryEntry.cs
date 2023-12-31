﻿// Copyright (c) Kevin BEAUGRAND. All rights reserved.

using System;

namespace SemanticKernel.Connectors.Memory.SqlServer;

/// <summary>
/// A sql memory entry.
/// </summary>
public record struct SqlServerMemoryEntry
{
    /// <summary>
    /// The unique identitfier of the memory entry.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The entry collection name.
    /// </summary>
    public string Collection { get; set; }

    /// <summary>
    /// Unique identifier of the memory entry in the collection.
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    /// Metadata as a string.
    /// </summary>
    public string MetadataString { get; set; }

    /// <summary>
    /// The embedding.
    /// </summary>
    public ReadOnlyMemory<float>? Embedding { get; set; }

    /// <summary>
    /// Optional timestamp. Its 'DateTimeKind' is <see cref="DateTimeKind.Utc"/>
    /// </summary>
    public DateTimeOffset? Timestamp { get; set; }
}
