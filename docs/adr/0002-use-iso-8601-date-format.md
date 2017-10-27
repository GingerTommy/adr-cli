# 2. Use ISO 8601 Date Format

2017-07-03

## Status

Accepted

## Context

`adr-cli` seeks to communicate the history of architectural decisions of a project. An important component of the history is the time at which a decision was made.

To communicate effectively, `adr-tools` should present information as unambiguously as possible. That means that culture-neutral data formats should be preferred over culture-specific formats.

Existing adr-tools deployments format dates as dd/mm/yyyy by default. That formatting is common formatting in the United Kingdom (where the project was originally written), but is [easily confused](https://xkcd.com/1179/) with the mm/dd/yyyy format preferred in the United States.

## Decision

`adr-cli` will use the ISO 8601 format for dates:  `yyyy-mm-dd`

## Consequences

Dates are displayed in a standard, culture-neutral format.

The UK-style and ISO 8601 formats can be distinguished by their separator character.  The UK-style dates used a slash (`/`), while the ISO dates use a hyphen (`-`).

Prior to this decision, `adr-cli` was deployed using the UK format for dates. After adopting the ISO 8601 format, existing deployments of `adr-cli` must do one of the following:

 * Accept mixed formatting of dates within their documentation library.
 * Manually update existing documents to use ISO 8601 dates.