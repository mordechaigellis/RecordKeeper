create or alter procedure dbo.PresidentDelete(@PresidentId int, @Message varchar(1000) = '' output)
as
begin
    declare @return int = 0
    
    delete President where PresidentId = @PresidentId

    return @return
end
go