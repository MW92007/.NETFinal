# CONTRIBUTIONS

> **Required for ALL tiers.** Replace the bracketed prompts with your own
> answers. Honesty is graded; volume is not. One paragraph per section is
> usually enough — be specific, not impressive.

---

## 1. Starting Point

I started at the WK15 template. We discussed this in class.

> **Example:** *"I started from my own W14 repo and pulled MapManager.cs and
> ExplorationUI.cs from the W15 template. My existing GameContext, models,
> and migrations carried forward unchanged."*
>
> **Or:** *"I started from a fresh clone of the W15 template because my own
> code stopped working after W13 and I couldn't recover it."*

---

## 2. What I Added

AdminService.MostDangerousRoom() - LINQ that gathers all of the rooms, reads how many monsters are in there, sums their HP, and then displays the top (first) room with the most HP.

AdminService.InventoryAudit() - LINQ that aquires all available Item types and displays them in the tables they're founded in.

AdminService.LockedTreasures() - LINQ that finds all chest types and displays them and their current states and what is required to unlock them if necessary.

AdminService.FloorSweep() - LINQ that gathers all rooms, totals the Value of all items currenlty on the floor, and then returns it.

Slime.cs - New Slime Enemy type that does compound damage, bounding as many times equal to the unique GelatinousBile characteristic.

> **Example:**
> - `AdminService.MostDangerousRoom()` — LINQ `GroupBy` on `Monster.CurrentRoomId`
>   summing Health to find the riskiest area. Wired into the admin menu.
> - New `Orc : Monster` subclass with a `Strength` stat. New migration
>   `AddOrcMonster`, plus one seed row added to `SeedFinalWorld.sql`.
> - Added a `Shop` container in Town Square that exchanges items for gold.
>   New `Shop : Container` subclass, `Player.Gold` field, two new migrations.

---

## 3. What I Used From the Template / AI / Other Sources

Most of my program was Template code obviously. I had to use AI for bug fixing a lot, as mentioned in the video there was a point in which my character was dying
before she even started the game. LockedTreasures in particular was one that I needed help with. There were many times wwhen my Migrations would break and I would go nuts trying to fix it, so there may be small changes littered around that went undocumented.

> **Example:**
> - `MapManager.cs`, `ExplorationUI.cs`: used as-is from the W15 template.
> - `GameEngine.HandleChest`: copied from the W15 template, then modified
>   to add a "magical inspect" option for cursed chests.
> - `AdminService.MonsterCensus`: my own code, but the `GroupBy` pattern is
>   based on the W12 in-class `ListItems` example.
> - GitHub Copilot helped me draft the regex in `Shop.ParseTradeCommand`.
>   I rewrote ~half of it after testing.

---

## 4. Reflection on This Project (one paragraph)

The hardest part of my project was just getting a grasp. For a while the concepts were very confusing and I was stubborn for not asking for help.
A little late, but I think I'm starting to get the handle of how eveyrthing works. Especially with Migrations, trying to get my new Slime into the FinalWorldSeed was a pain in the butt. I think I got it in the end. For the future, I think I might work on this project in my free time. I was able to get a basic understanding of the LINQ through mimicry, but I think I could get it down with more practice. I tried to shoot for an A, but we'll see how this goes.

> **Example:** *"The hardest part was figuring out why my Shop migration
> kept breaking — I'd forgotten to add the discriminator value in
> GameContext, so EF Core kept generating an empty migration. Took me an
> hour with the migration script generator to spot it. If I had another
> week I'd add a quest log, because I think the data model would be a fun
> exercise (Quest entity + Player→Quest many-to-many + a goal-state checker)."*

---

## 5. Course Feedback (NOT graded — please be candid)

Help me make this class better next time. **This section is not part of
your project grade.** I read it after grades are submitted, and I'd much
rather hear "week X was painful because Y" than diplomatic non-answers.
Concrete > polite.

**What did you learn that genuinely stuck with you?**
I thought SOLID was interesting, I hadn't had to encounter it before so it was neat to watch it be explained practically.

**What did you like about the course?**
I liked the course in general. The templates are amazing, there's plenty of resources, it was very balanced.

**What didn't work for you?**
Just migrations, but I feel that that is more of a personal issue.

**What surprised you?**
LINQ by far. I still question why I get it wrong sometimes, it's oddly frustrating.

**What was the hardest part of the semester (not just this project)?**
Getting a hold of the concepts as we went.

**What would you ADD to next year's version?**
I don't really know for sure.

**What would you REMOVE or shorten?**
There wasn't anything that struck out as too much.

**Anything else?**
Nothing else from me, I hope you have a great summer!
---

## How this is graded

**Sections 1-4** are the **gate to all rubric tiers.** Without a complete
and honest accounting of your starting point, additions, sources, and
project reflection, the project caps at 50% regardless of code quality.

- **Base/B/A/A+** all require Sections 1-4 to be filled out and to match
  what's actually in your repo.
- During your final presentation I may ask you to walk through any file
  you describe yourself as "added" or "modified" — be ready.
- Using template code with clear attribution is fine and earns full credit.
  Claiming to have written code you didn't is not, and will be graded
  as such (zero on the affected tier).

**Section 5 is not graded.** It exists to make the class better. A blank
Section 5 won't lower your grade; an honest critical Section 5 won't
either. The only "wrong" answer there is a fake one.

Think of Sections 1-4 as the README every PR needs: a short story about
what changed and why. It's a real engineering skill, and it's the most
reliable way for me to grade what you actually did.
