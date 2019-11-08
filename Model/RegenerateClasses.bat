REM

echo "Regenerating the liquid xml classes from the schema."

"C:\Program Files\Liquid Technologies\Liquid Studio 2018\XmlDataBinder16\LXDB16.exe" /NG /V /T XSD /F "Schemas\Car.xsd" /L C# /TP Standard20 /X ".." /O "Model" /Col PLUR /NP /N "Model"

del "Schemas\*.xml"
del "Schemas\Car.xsd.Output\*.*" /s /q
rmdir "Schemas\Car.xsd.Output" /s /q

