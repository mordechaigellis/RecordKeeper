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

select * from Party p order by p.PartyId desc