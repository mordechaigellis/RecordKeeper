insert president(Num, FirstName, LastName, Party, dateBorn, DateDied, TermStart, TermEnd)
select 1, 'George', 'Washington', 'None, Federalist', '1732-02-22', '1799-12-14', 1789, 1797
union all select 1, 'George', 'Washington', 'None, Federalist', '1732-02-22', '1799-12-14', 1789, 1797

select * from president p order by p.Num