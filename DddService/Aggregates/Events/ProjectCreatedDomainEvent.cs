using DddService.Common;

namespace DddService.Aggregates.Events;

public record ProjectCreatedDomainEvent(Guid ProjectId, string ProjectName) : IDomainEvent;































// public record CommandAddedToProjectDomainEvent(Guid ProjectId, Guid CommandId) : IDomainEvent;

// public record SprintAddedToProjectDomainEvent(Guid ProjectId, Guid SprintId) : IDomainEvent;

// public record DeveloperAddedToProjectDomainEvent(Guid ProjectId, Guid DeveloperId) : IDomainEvent;
