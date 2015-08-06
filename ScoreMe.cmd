@echo Testing your project
@pushd .
@cd CSExercises\bin\debug
@"%VS120COMNTOOLS%\..\ide\commonextensions\microsoft\testwindow\vstest.console.exe" ..\..\..\ExercisesTest.dll 
@popd
@type .git\FETCH_HEAD
