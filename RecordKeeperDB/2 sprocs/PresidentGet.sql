create or alter procedure dbo.PresidentGet(
    @PresidentId int = 0,
    @Num int = 0,
    @Code varchar(250) = '',
    @PartyName varchar(35) ='',
    @All bit = 0,
    @Message varchar(1000) = '' output
)
as
begin
    declare @return int = 0
    
    select @PresidentId = isnull(@PresidentId,0), @All = isnull(@All,0), 
    @Num = isnull(@Num,0), @Code = isnull(@Code,0), @PartyName = isnull(@PartyName,'')

    select p.PresidentId, p.PartyId, a.PartyName, p.Num, p.FirstName, p.LastName, p.YearBorn, p.YearDied, p.TermStart, p.TermEnd,
        p.DateBorn, p.DateDied, p.Code
    from President p 
    join Party a
    on a.PartyId = p.PartyId
    where p.PresidentId = @PresidentId
    or @All = 1
    or p.Num = @Num
    or p.Code = @Code
    or a.PartyName = @PartyName
    order by p.Num

    finished:

    return @return
end

GO
exec PresidentGet @PartyName = 'Whig'
exec PresidentGet @Code = '1-George-Washington'
exec PresidentGet @Num = 46

exec PresidentGet @PresidentId = 1602

exec PresidentGet @All = 1

exec PresidentGet @PresidentId = 1602, @All = null



exec PresidentGet