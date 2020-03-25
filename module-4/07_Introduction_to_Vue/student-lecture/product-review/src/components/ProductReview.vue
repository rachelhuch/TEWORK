<!-- To get scaffolding, type "<vue" and hit tab-->
<div>
<template>
  <div class = "main">
      <h2> Product Reviews for Cigar {{name}} </h2>
      <p class ="highlighted">{{description}}</p>
      </div>
</template>
</div>
<script>
export default {
    name:"product-review"
    data() {
        return {
            name: "Cigar Parties for Dummies", 
            description: "Host and plan the perfect cigar party for all your squirrelly friends"
        };
    }
}
</script>

<style scoped>
.highlighted{
    background-color:yellow;
}
</style>
