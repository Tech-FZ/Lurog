# Lurog v2024.9.1.2

## Lurog Basidocs v2024.9.29.0

- Changelog updates

## Lurog.NET v0.0.2.2_proto

- Removal of the `virtual` modifier in the console log because we have an interface for that. 😉
- A file logger is in preparation
- The "addargs" had to be introduced.

# Lurog v2024.9.0.1

## Lurog Basidocs v2024.9.14.0

- Added Readme, Contributors and Changelog
- Added .gitignore
- The contributor list has been restructured.

## Lurog.NET v0.0.1.1_proto

- Added ILogger interface.
- Added Logger class inheriting from ILogger.
- Added an enum with severities.
	- The "General" enum has been removed.
- Added ErrorRaisedEventArgs inheriting from EventArgs.
- Changed parametres for ILogger.Log()
- Made a template console log method.