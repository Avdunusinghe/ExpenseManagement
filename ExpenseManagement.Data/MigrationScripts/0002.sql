BEGIN TRANSACTION;
GO

ALTER TABLE [Items] DROP CONSTRAINT [PK_Items];
GO

EXEC sp_rename N'[Items]', N'Item';
GO

ALTER TABLE [Item] ADD CONSTRAINT [PK_Item] PRIMARY KEY ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211105155429_ExpenseManagement00002', N'5.0.11');
GO

COMMIT;
GO

