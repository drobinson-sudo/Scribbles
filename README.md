# Scribbles
Desktop only blogging app for WinForms, no database needed.

Project for Programming I . 
This is a flat file based blogging app that only lives on your desktop. 
It includes some limited formatting for posts, help files built-in, and
options to edit a post after it has been published.

The posts are saved as simple text files, all the post meta info is parsed
out during the Read Loop. Each post becomes an object, and the associated
info becomes its properties.

Be sure the ctlPostExcerptLib is included in the solution. This is a custom
control that allows post excerpts to fill the Home screen.
