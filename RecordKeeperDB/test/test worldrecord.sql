insert WorldRecord (Category, RecordName, RecordDesc, FullName, Amount, UnitOfMeasure, YearAchieved, Country) 
--unique constraint on code Largesthorncircumfer2003
select 'Animals', 'Largest horn circumference on a disc', 'The largest horn circumference on a steer measured 95.25 cm (37.5 in) on 6 May 2003 and belong to Lurch, an African watusi steer owned by Janice Wolf (USA) of Gassville, Arkansas, USA. Sadly, Lurch died at 3 p.m. on 22 May 2010 of a cancer at the base of one of the horns. The body has has been released to a local taxidermist, who will produce a full-sized taxidermy of the steer.', 'Lurch', 95.25, 'Centimetres', 2003, 'USA'
--select null, 'Largest horn circumference on a steer ever', 'The largest horn circumference on a steer measured 95.25 cm (37.5 in) on 6 May 2003 and belong to Lurch, an African watusi steer owned by Janice Wolf (USA) of Gassville, Arkansas, USA. Sadly, Lurch died at 3 p.m. on 22 May 2010 of a cancer at the base of one of the horns. The body has has been released to a local taxidermist, who will produce a full-sized taxidermy of the steer.', 'Lurch', 95.25, 'Centimetres', 2003, 'USA'
--select 'animals', null, 'The largest horn circumference on a steer measured 95.25 cm (37.5 in) on 6 May 2003 and belong to Lurch, an African watusi steer owned by Janice Wolf (USA) of Gassville, Arkansas, USA. Sadly, Lurch died at 3 p.m. on 22 May 2010 of a cancer at the base of one of the horns. The body has has been released to a local taxidermist, who will produce a full-sized taxidermy of the steer.', 'Lurch', 95.25, 'Centimetres', 2003, 'USA'
--select '', 'some record', 'The largest horn circumference on a steer measured 95.25 cm (37.5 in) on 6 May 2003 and belong to Lurch, an African watusi steer owned by Janice Wolf (USA) of Gassville, Arkansas, USA. Sadly, Lurch died at 3 p.m. on 22 May 2010 of a cancer at the base of one of the horns. The body has has been released to a local taxidermist, who will produce a full-sized taxidermy of the steer.', 'Lurch', 95.25, 'Centimetres', 2003, 'USA'
--select 'Animals', '', 'The largest horn circumference on a steer measured 95.25 cm (37.5 in) on 6 May 2003 and belong to Lurch, an African watusi steer owned by Janice Wolf (USA) of Gassville, Arkansas, USA. Sadly, Lurch died at 3 p.m. on 22 May 2010 of a cancer at the base of one of the horns. The body has has been released to a local taxidermist, who will produce a full-sized taxidermy of the steer.', 'Lurch', 95.25, 'Centimetres', 2003, 'USA'
--select 'Animals', 'some record', '', 'Lurch', 95.25, 'Centimetres', 2003, 'USA'
--test 0 or negative amount
--select 'A', 'B', 'C', 'D', -1, 'Centimetres', 2003, 'USA'
--test invalid year achieved
--select 'A', 'B', 'C', 'D', 1, 'Centimetres', 1899, 'USA'
--union select 'A', 'Ba', 'Ca', 'Da', 10, 'metres', 1299, 'USA'
--test for USA < 1776
select 'A', 'B', 'C', 'D', 1, 'Centimetres', 1775, 'USA'
--select * from WorldRecord order by RecordName

select *
from WorldRecord