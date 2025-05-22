# Lernperiode 5

2.5 bis 23.5

## Grob-Planung

Wie können Sie Ihr Projekt aus der Lernperiode 4 um eine Persistenz-Lösung erweitern? Was gibt es zu speichern, was für Tabellen brauchen Sie und wie muss der bestehende Code mit diesen interagieren?

Um mein Projekt aus der Lernperiode 4 um eine Persistenz-Lösung zu erweitern füge ich eine Option ein, welche das Spiel Speichert. Gespeichert werden muss die Anzahl Cookies, die Stufen der Level und Preise und die CookiesPerSecond (CPS) wofür es eine Tabelle braucht. In der Tabelle werden die einzelnen Spalten hinzugefügt.

## 2.5

- [ ] Code mit Datenbank verbinden
- [X] Tabelle Erstellen und mit den nötigen Daten ausfüllen

Heute habe ich zuerst probiert mit SQLite mein Code mit einer Datenbank zu verbinden. Diese Idee habe ich dann aber verworfen, weil ich es zu schlecht verstanden habe. Danach habe ich in MSSQLMS eine Datenbank erstellt. In die Datenbank habe ich alle Spalten die ich für meinen Cookie Clicker brauche hinzugefügt. In den Visual Studio Code habe ich noch nichts neues Reingeschrieben. Den Code habe ich noch nicht verbunden mit dem Code, da ich noch keine Zeit hatte es zu machen und noch nicht weiss wie es geht.

## 9.5 Kernfunktionalität

- [X] Spielernamen Spalte in Datenbank hinzufügen
- [X] Datenbank mit Code verbinden
- [ ] Option zum Namen geben im Spiel einfügen

Heute habe ich zuerst wieder angefangen, mein Programm mit Sqlite zu verbinden. Als Erstes habe ich die neue Datenbank erstellt. Danach habe ich den Code geschrieben, dass das Programm auf die Datenbank zugreifen kann. Als Nächstes habe ich neue Buttons in meinen Overlays hinzugefügt. Als Letztes habe ich noch eine längere Zeit probiert, Code zum Speicher zu schreiben. Ich weiss noch nicht, ob es funktioniert, aber ich denke noch nicht.

## 16.5 Kernfunktionalität und Ausbau

- [X] Speicher Option fertig machen
- [X] Spielstand laden Funktion Coden
- [X] Spielstand Löschen Funktion Coden
- [ ] Option zum Namen geben im Spiel einfügen

Heute habe ich als Erstes eine Pop-up-Meldung hinzugefügt, die zeigt, ob der Spielstand gespeichert wurde oder es einen Fehler gab. Als Nächstes habe ich den Load Game Button so konfiguriert, dass, wenn man drauf drückt, der zuletzt gespeicherte Spielstand geladen wird. Es werden alle Daten in die Variablen geladen und danach angezeigt. Als Nächstes habe ich den Reset-Button gemacht, mit dem man das Spiel zurücksetzen kann. Da werden alle Werte auf ihren Standardwert gesetzt und neu angezeigt. Dies muss man in einer Pop-up-Mitteilung bestätigen. Zum Schluss habe ich noch hinzugefügt, dass das Shopfenster von Anfang an geöffnet ist und der Fenster schliessen (X) Knopf gesperrt ist. 

## 23.5 Abschluss

- [x] Abfrage ob man wirklich den Spielstand Speichern will
- [x] Abfrage ob man wirklich den Spielstand laden will
- [x] Versuchen dass der Autoklicker nach dem Laden eines Spielstandes direkt läuft
- [x] Reflexion über Ihre Arbeitsweise
- [x] Beschreibung des fertigen Projekts mit .gif etc.

Heute habe ich damit begonnen, die Abfragen zum laden/speichern zu machen. Dies war nicht sehr schwer, da ich die Abfrage schon beim Zurücksetzen hatte. Als Letztes musste ich mir noch überlegen, wie ich den Autoklicker nach dem Spielstand laden zum laufen bringe. Nach etwas überlegen ist mir aufgefallen, dass es dasselbe wie beim 2x Upgrade Timer ist. Also habe ich einfach geschrieben, dass der Timer beim laden gestartet wird.

## Fertiges Projekt

Mein fertiges Projekt ist der Cookie Clicker aus Lernperiode 4 mit einer angehängten Datenbank. Somit kann man jetzt den Spielstand speichern, nach dem Schliessen des Programmes den gespeicherten Spielstand laden und den gesamten Spielstand resetten. 

![GIF LP5](https://github.com/user-attachments/assets/ef232700-774c-4d66-bdba-9ab2ba9de2d0)


## Reflexion

In der 5. Lernperiode lief es grundsätzlich sehr gut. Am Anfang habe ich zwar nicht wirklich verstanden, wie es funktionieren soll, was sich aber schnell geändert hat. Ich hatte anfangs Probleme mit dem Laden und Speichern von Daten. Nach etwas herumprobieren und Recherchieren habe ich langsam verstanden. Gelernt habe ich, wie man Daten aus einfachen Datenbanken ein- und herauslesen kann, sodass sie direkt im Spiel verwendet werden können. Ausserdem habe ich gelernt, wie man Messageboxen erstellt, da ich die vorher nicht gebraucht habe. Für die nächste Lernperiode und das nächste Jahr nehme ich mir vor, ordentlicher zu Arbeiten und den Variablen einfacher zuzuordnende Namen zu geben.
