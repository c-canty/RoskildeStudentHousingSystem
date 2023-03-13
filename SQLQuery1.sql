SELECT s.Id AS StudentId, s.Name AS StudentName, r.Id AS RoomId, d.address,d.Name, r.Price,r.Type AS RoomType,l.DateFrom,l.DateTo 
FROM Leasing AS l 
JOIN Student AS s ON s.Id = l.StudentId 
JOIN Dormitory AS d ON d.Id = l.DormId 
JOIN Room AS r ON r.Id = l.RoomId WHERE s.Id = 'chre38eb';