# 3. Use docs/adr as folder

2017-10-27

## Status

Accepted

## Context

`adr-cli` needs to store the markdown files somewhere.

[Michael Nygard's article](http://thinkrelevance.com/blog/2011/11/15/documenting-architecture-decisions) proposes `doc/arch/adr-NNN.md` as directory and filename pattern.
[adr-tools](https://github.com/npryce/adr-tools) uses `docs/adr/NNNN-title-with-dashes.md` as pattern.

## Decision

Use `docs/adr/NNNN-title-with-dashes.md` as pattern to be
1) consistent with adr-tools and
2) enable rendering in GitHub pages, because GitHub pages can be rendered from the `docs/` sub folder, but not from `doc` subfolder.

## Consequences

1. Pedantic readers of Michael Nygard's article will note a difference in the directory structure.
2. The ADRs can be rendered as GitHub pages.
3. [adr-log](https://adr.github.io/adr-log/) can be used to create an `index.md` file forming an index of all architectural decisions.
