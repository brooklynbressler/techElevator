<template>
<article>
  <div class="card" v-bind:class="{ read: book.read }" v-bind:key="book.id">
    <h2 class="book-title"> {{ book.title }} </h2>
    <img v-if="book.isbn" v-bind:src="'http://covers.openlibrary.org/b/isbn/' + book.isbn + '-M.jpg'" /> 
    <h3 class="book-author"> {{ book.author }} </h3>   
    <p>
      <input type="button" value="Mark Read" class="mark-read" v-if="! read"
      v-bind:clicked="book.read"
      v-on:click="markedRead(book)"
      />

      <input type="button" value="Mark Unread" class="mark-unread" v-if="read"
      v-bind:clicked="book.read"
      v-on:click="markedUnread(book)"
      />
    </p>
  </div>
</article>
</template>

<script>
export default {
    name: 'book-card',
    props: ['book'],
    methods: {
    markedRead(r) {
      this.$store.commit("MARK_READ", r);
    },

    markedUnread(u) {
      this.$store.commit("MARK_UNREAD", u);
    },
  }
}
</script>

<style>
.card {
    border: 2px solid black;
    border-radius: 10px;
    width: 250px;
    height: 550px;
    margin: 20px;
}

.card.read {
    background-color: lightgray;
}

.card .book-title {
    font-size: 1.5rem;
}

.card .book-author {
    font-size: 1rem;
}
</style>