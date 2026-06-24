# Design Notes

This document tracks key design decisions made throughout the build, and the
reasoning behind them. Organised by phase to mirror the project's incremental
build order.

---

## Phase 0 — Repo Setup

**Decision:** Separate public GitHub repo, distinct from bootcamp Azure DevOps.

**Why:** This project is intended as a standalone portfolio piece. Keeping it
on GitHub (public, recruiter-accessible) rather than ADO (private, bootcamp-only)
means it can be shared directly in job applications without needing to extract
or migrate it later.

**Decision:** Design decisions tracked in this dedicated file rather than only
in code comments.

**Why:** A single narrative document is easier to read end-to-end (by an
interviewer, or by future me) than decisions scattered across files. It also
doubles as interview preparation — a ready answer to "walk me through a
decision you made on this project."

---

## Phase 1 — Foundations

**Decision:** `Balance` uses `{ get; private set; }` rather than a fully public setter.

**Why:** Encapsulation — the only legitimate way to change an account's balance
is through `Deposit()`/`Withdraw()`, which validate the amount first (no
negative deposits, no overdrawing). A public setter would let any code bypass
those rules entirely (e.g. `account.Balance = -500;`), which a real banking
system can't allow.

**Decision:** `AccountNumber` and `Owner` use `{ get; }` with no `set` at all.

**Why:** These values are fixed at the point an account is opened and should
never change afterward. `private set` would still allow internal code to
change them later; using no `set` at all is stricter and matches the real-world
rule that an account number doesn't change.

**Decision:** `decimal` instead of `double`/`float` for `Balance`.

**Why:** `double`/`float` can introduce small rounding errors in arithmetic,
which is unacceptable for monetary values. `decimal` is the type .NET
recommends specifically for financial calculations.

**Decision:** `_transactionLog` is a private `List<string>` with no public
property wrapper at all (not even a `get`).

**Why:** Stricter encapsulation than `Balance` — external code shouldn't see
the raw log directly under any circumstance, only through
`PrintTransactionHistory()`, which controls how it's displayed.

**Decision:** Two separate validation checks in `Withdraw()` (`amount <= 0`
and `amount > Balance`), each throwing its own exception with a distinct
message.

**Why:** These are two different failure conditions ("invalid input" vs.
"insufficient funds") that a caller or future error-handling code may want
to distinguish between, rather than collapsing into one generic error.

---

## Phase 2 — Multiple Accounts & Collections

_To be completed._

---

## Phase 3 — Account Hierarchy

_To be completed._

---

## Phase 4 — Interfaces & Dependency Injection

_To be completed._

---

## Phase 5 — SOLID Pass

_To be completed._

---

## Phase 6 — Unit Testing & TDD

_To be completed._

---

## Phase 7 — Design Patterns

_To be completed._
