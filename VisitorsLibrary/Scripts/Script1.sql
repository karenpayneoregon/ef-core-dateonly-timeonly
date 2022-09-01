DECLARE @VisitorIdentifier AS INT = 3;

SELECT VL.VistorLogIdentifier,
       VL.VisitorIdentifier,
       VL.VisitOn,
       VL.EnteredTime,
       VL.ExitedTime,
       V.FirstName,
       V.LastName
FROM dbo.VisitorLog AS VL
    INNER JOIN dbo.Visitor AS V
        ON VL.VisitorIdentifier = V.VisitorIdentifier
WHERE (VL.VisitorIdentifier = @VisitorIdentifier)
ORDER BY VL.VisitOn DESC;

SELECT VL.VistorLogIdentifier,
       VL.VisitorIdentifier,
       VL.VisitOn,
       VL.EnteredTime,
       VL.ExitedTime,
       V.FirstName,
       V.LastName
FROM dbo.VisitorLog AS VL
    INNER JOIN dbo.Visitor AS V
        ON VL.VisitorIdentifier = V.VisitorIdentifier
ORDER BY VL.VisitOn DESC;
