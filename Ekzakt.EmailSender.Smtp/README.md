﻿# Ekzakt.EmailSender.Smtp
Package for sending emails via an smtp-server and is merely a small wrapper around
the [MimeKit](https://github.com/jstedfast/MimeKit) and [MailKit](https://github.com/jstedfast/MailKit) repo.

## Installation

### 1. Install package
Use the NuGet Package Manager and search for Ekzakt.EmailSender.Smtp, or use the dotnet CLI:
``` C#
dotnet add package Ekzakt.EmailSender.Smtp
```

### 2. Register the class in startup.cs
``` C#
builder.Services.AddScoped<IEmailSenderService, SmtpEmailSenderService>();
```

## Usage
Import the namespace Ekzakt.EmailSender.Smtp in every class you want to use it.
``` C#
import Ekzakt.EmailSender.Smtp
```

## License
[MIT](https://choosealicense.com/licenses/mit/)