create or alter procedure dbo.ExecutiveOrderGet(@PresidentId int)
as
begin
    select e.ExecutiveOrderId, e.PresidentId, e.OrderName, e.OrderNumber, e.PageNum, e.Reference, e.YearIssued, e.UpheldByCourt
    from ExecutiveOrder e
    where e.PresidentId = @PresidentId
    order by e.Reference
end
go
select * from President
--select * from ExecutiveOrder
exec ExecutiveOrderGet @PresidentId = 1090