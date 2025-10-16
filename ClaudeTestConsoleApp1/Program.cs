using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using System.Reflection;

// Determine the path to the Log directory (one level up from the project folder)
// Project folder is ClaudeTestProjects, so one level up means the parent directory
var currentDir = Directory.GetCurrentDirectory();
var logDirectory = Path.GetFullPath(Path.Combine(currentDir, "../Log"));
var logFilePath = Path.Combine(logDirectory, "application.log");

// Ensure Log directory exists
if (!Directory.Exists(logDirectory))
{
    Directory.CreateDirectory(logDirectory);
}

// Configure Log4Net programmatically
var hierarchy = (Hierarchy)LogManager.GetRepository(Assembly.GetEntryAssembly());

var patternLayout = new PatternLayout
{
    ConversionPattern = "%date [%thread] %-5level %logger - %message%newline"
};
patternLayout.ActivateOptions();

var roller = new RollingFileAppender
{
    AppendToFile = true,
    File = logFilePath,
    Layout = patternLayout,
    MaxSizeRollBackups = 10,
    MaximumFileSize = "10MB",
    RollingStyle = RollingFileAppender.RollingMode.Size,
    StaticLogFileName = true
};
roller.ActivateOptions();
hierarchy.Root.AddAppender(roller);

hierarchy.Root.Level = Level.Info;
hierarchy.Configured = true;

// Get logger instance
var log = LogManager.GetLogger(typeof(Program));

// Log Info message
log.Info("Hello Mike!");

Console.WriteLine("Hello Mike!");
