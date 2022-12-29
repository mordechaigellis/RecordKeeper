create or alter procedure dbo.PartyUpdate(
    @PartyId int = 0 output,
	@PartyName varchar(35),
	@YearStart smallint, 
	@PartyColor varchar(20),
    @Message varchar(1000) = '' output
)
as
begin
    declare @Return int = 0

    select @PartyId = isnull(@PartyId,0), @PartyName = isnull(@PartyName,''), @PartyColor = isnull(@PartyColor,'')

    if @PartyId = 0
    begin
        insert party(PartyName, YearStart, PartyColor)
        values (@PartyName, @YearStart, @PartyColor)

        select @PartyId = scope_identity()
    end
    else
    begin
        update Party
        set PartyName = @PartyName, 
            YearStart = @YearStart,
            PartyColor = @PartyColor
        where PartyId = @PartyId
    end

    return @Return
end

go
delete Party where PartyName = 'Tea Party'

declare @Return int, @Message varchar(1000), @PartyId int

exec @Return = PartyUpdate 
@PartyId = @PartyId output,
@PartyName = 'Tea Party',
@YearStart = '2000',
@PartyColor = 'LightBrown',
@Message = @Message output


select * from Party p order by p.PartyId desc

exec @Return = PartyUpdate 
@PartyId = @PartyId output,
@PartyName = 'Tea Party',
@YearStart = '2001',
@PartyColor = 'LightGreen',
@Message = @Message output
