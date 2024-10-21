<a id="readme-top"></a>

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/github_username/repo_name">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">Murder At Supper</h3>

  <p align="center">
    Welcome to the official GitHub repository for<br />
    <i>Murder at Supper</i> by Epic Epic Games!
    <br />
  </p>
</div>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#credits">Credits</a></li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<ol>
  <li>Credits</li>
  <li>Usage
    <ol type="i">
      <li>Overview</li>
    </ol>
  </li>
  <li>Acknowledgments</li>
</ol>

<!-- CREDITS -->
## Credits

Epic Epic Games is...

* Nicole Scalera | [Atomic-Atlas](https://github.com/Atomic-Atlas)
* Ferris Milinazo | [Ferris991](https://github.com/Ferris991)
* Abby Agostin | [AbigailAgostin](https://github.com/AbigailAgostin)
* Kendall Pastreich | (insert GitHub later)
* Alyssa Mazur | [amazurr](https://github.com/amazurrsi)
* Brenden Moloney | [realBMOLDIGITAL](https://github.com/realBMOLDIGITAL)

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- USAGE -->
## Usage

<div style="font-size:16px;">

The purpose behind this repository is to...

  <ol>
    <li>Quickly and easily share files</li>
    <li>Track progress and maintain an organized workflow</li>
    <li>Periodically create stable builds of our game</li>
    <li>Systematically identify and fix errors, *without* corrupting said builds</li>
    <li>Develop comprehensive and user-friendly documentation</li>
  </ol>

Please check out the sections below for all the information on this repository.

</div>

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- OVERVIEW -->
## Overview

<p style="font-size:16px;">Hello everyone! For easy reading, I've broken the rules up into bite-sized sections. Feel free to skim past any sections you know already. Please let me know if you have any questions.</p>

### What Is a Repository?

A repository is what you are looking at right now! It's a central location where you can keep all of your files.

<img src="02 Documentation\00 Assets\README\repository_def.png" width="500"></img>

In the case of GitHub, we can all contribute to this same repository to track and synchronize our work, even when we're apart.

### How Will the Repository Be Used?

If you're brand new to GitHub, here’s what you need to know.

You can interact with this repository <a href="#what-does-remote-mean">remotely through browser</a> or <a href="#what-does-local-mean">locally through your machine</a> via the [GitHub Desktop](https://desktop.github.com/download/) application.

You will make changes to the repository through <a href="#committing">**commits**</a> and <a href="#pull-requests">**pull requests**</a>.

<br></br>

<!-- COMMITTING -->
## Committing

### What Is Committing?
Everytime you make changes to your repository, it is called a "commit."

Commits can be thought of as a 'Save Game' function.

<img src="02 Documentation\00 Assets\README\quicksave_meme.png" width="400"></img>

In the case of GitHub, they act as these little snapshots of your respository at specific times in its progression.

Just like in a video game, you should "save" your progress often by making new commits. This helps you and team members keep track of updates.

Additionally, in the event of project issues, you can roll back changes and return to a previous version of your project.

### How Do I Commit?

There are two ways to commit to the GitHub:
1. Remotely through your browser
2. Locally from your machine

You can learn about the <a href="#remote-vs-local">differences between these methods</a> and <a href="#uploading-things--making-changes">how to follow them</a> in the sections below.

<br></br>

## Remote vs. Local

### What Does Remote Mean?
"Remote" refers to a version of your project that is stored on a server everyone has access to (namely, the GitHub website).

It's like a shared Google Docs file versus a personal Word Doc. The remote repository is the shared Google Document that all team members can collaborate on in real time.

This workflow concept can be visualized through [this diagram](https://git-scm.com/book/en/v2/Getting-Started-About-Version-Control) from the official [Progit book](https://git-scm.com/book/en/v2).

<img src="02 Documentation\00 Assets\README\centralized_ver_control_diagram.png" width="600"></img>

However, this diagram *only* applies if you're making edits exclusively through the browser. If you want to make edits from your machine, take a look at the section below.

### What Does Local Mean?
In contrast, "Local" surrounds the idea of everything that is locally available to *you* and only you. In other words, your personal machine. The [diagram](https://git-scm.com/book/en/v2/Getting-Started-About-Version-Control) below illustrates this concept.

<img src="02 Documentation\00 Assets\README\distributed_ver_control_sys.png" width="500"></img>

As you can see, Computer A and Computer B both sync to the same remote repository, but have their own individual versions of the project. That way they can make changes and not corrupt the repository altogether. When you are ready, you can sync your local repository with the remote repository through pushing and pulling.

Note: To Programmers reading this, keep in mind that the workflow may be manipulated through different branches to ensure the stability of the project. As of right now, though, aforementioned concept illustrates the bare bones level of this project.

<br></br>

## Uploading Things & Making Changes

### I Want to Upload Files Through My Browser (Remote)

The people committing remotely will most likely be Writers and Artists. To commit remotely, visit [this repository](https://github.com/Atomic-Atlas/MaS) on [GitHub.com](https://github.com/) and upload files to the correct folders.

<img src="02 Documentation\00 Assets\README\create_or_upload.png" width="600"></img>

Be sure to enter the <a href="#title-and-description">title and description</a> of your change.

<img src="02 Documentation\00 Assets\README\summary_box_remote.png" width="600"></img>

### I Want to Upload Files From My Computer (Local)

The people committing locally will most likely be Programmers. To commit locally, use the [GitHub Desktop](https://desktop.github.com/download/) application.

It follows a very similar process, although it actively tracks your changes on your computer, and shows the difference between the remote repository (what's on the GitHub website) and the local repository (your machine).

Here is a screenshot of my local repository for *Murder at Supper* open on the GitHub Desktop app.

<img src="02 Documentation\00 Assets\README\ghd_interface.png" width="700"></img>

In the upper-left corner, right beneath the repository name, you can find the changes you've made. All changes will be selected automatically, but you can uncheck whatever you'd like to not be uploaded to the repository.

Sometimes it's best to pull from the repository before you push anything into it, which can be done by clicking the "Fetch Origin" button.

<img src="02 Documentation\00 Assets\README\fetch_origin.png" width="700"></img>

Like the last method, you will be prompted to create a <a href="#title-and-description">title and description</a> for your commit.

If you are confident on these edits, and are ready to push them to the main branch of the repository, you can click "Push Origin."

<img src="02 Documentation\00 Assets\README\push_origin.png" width="700"></img>

This command will sync your local and remote copies together.

<br></br>

## Committing Guidelines

### Title and Description
Regardless of which method you choose, you will always be prompted for a title and description of your changes. PLEASE, for your sake and everyone else's, add a description!

Adding a description will...
1. Eliminate the risk of forgetting what you were doing
2. Inform others of your changes (that way you don't have to reexplain yourself when you may be unavailable).
3. Make it easy to rollback changes.

### Template
Here is a template of what you might enter when you are making changes to the repository.

- **Title:** Created README<br>
- **Description:**
  - I created a README.md file at the root of the project.
  - This is intended to inform any viewers and contributors of what the project is about.
  - It contains:
    - Credits for Epic Epic Games
    - Description of GitHub key terms
    - Information on how to interact with the repository
    - and more

Remember: you're *not* writing the declaration of independence. Just a brief overview of what changes you've made, why you made them, what might be incomplete, what needs revisions, etc.


<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

* This README was authored by Nicole Scalera ([Atomic-Atlas](https://github.com/Atomic-Atlas)).
* I started this README file thru a template from the popular repository, [Best-README-Template](https://github.com/othneildrew/Best-README-Template), by [othneildrew](https://github.com/othneildrew) on GitHub.
* Many edits have been made to make it different and fit a sufficient README for *Murder at Supper* by Epic Epic Games.

<p align="right">(<a href="#readme-top">back to top</a>)</p>