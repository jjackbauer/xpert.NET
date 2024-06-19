namespace xpert_domain;

public record Change(Guid Id, Guid userId, DateTime ChangedAt, string ChangeDescriptionLog){}