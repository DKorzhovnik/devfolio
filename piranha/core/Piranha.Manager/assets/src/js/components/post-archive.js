Vue.component("post-archive", {
    props: ["uid", "id"],
    data: function() {
        return {
            items: [],
            categories: [],
            postTypes: [],
            status: "all"
        }
    },
    methods: {
        load: function () {
            var self = this;

            fetch(piranha.baseUrl + "manager/api/post/list/" + self.id)
                .then(function (response) { return response.json(); })
                .then(function (result) {
                    self.items = result.posts;
                    self.categories = result.categories;
                    self.postTypes = result.postTypes;
                })
                .catch(function (error) { console.log("error:", error ); });
        },
        remove: function (postId) {
            var self = this;

            fetch(piranha.baseUrl + "manager/api/post/delete/" + postId)
                .then(function (response) { return response.json(); })
                .then(function (result) {
                    piranha.notifications.push(result);

                    self.load();
                })
                .catch(function (error) { console.log("error:", error ); });
        },
        isSelected: function (item) {
            if (this.status === "draft") {
                return item.status === "draft" || item.status === "unpublished";
            }
            return true;
        },
        selectStatus: function (status) {
            this.status = status;
        }
    },
    mounted: function () {
        this.load();
    },
    beforeDestroy: function () {
    },
    template:
        "<div :id='uid'>" +
        "  <div class='mb-2'>" +
        "    <div class='btn-group' role='group'>" +
        "      <button v-on:click='selectStatus(\"all\")' class='btn btn-sm' :class='status === \"all\" ? \"btn-primary\" : \"btn-light\"' href='#'>All</button>" +
        "      <button v-on:click='selectStatus(\"draft\")' class='btn btn-sm' :class='status === \"draft\" ? \"btn-primary\" : \"btn-light\"' href='#'>Drafts</button>" +
        "      <button v-on:click='selectStatus(\"scheduled\")' class='btn btn-sm' :class='status === \"scheduled\" ? \"btn-primary\" : \"btn-light\"' href='#'>Scheduled</button>" +
        "    </div>" +
        "    <div v-if='postTypes.length > 1' class='btn-group' role='group'>" +
        "      <button type='button' class='btn btn-sm btn-light dropdown-toggle' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false'>" +
        "        All types" +
        "      </button>" +
        "      <div class='dropdown-menu dropdown-menu-right'>" +
        "        <a v-for='type in postTypes' href='#' class='dropdown-item'>{{ type.title }}</a>" +
        "      </div>" +
        "    </div>" +
        "    <div v-if='categories.length > 1' class='btn-group' role='group'>" +
        "      <button type='button' class='btn btn-sm btn-light dropdown-toggle' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false'>" +
        "        All categories" +
        "      </button>" +
        "      <div class='dropdown-menu dropdown-menu-right'>" +
        "        <a v-for='category in categories' href='#' class='dropdown-item'>{{ category.title }}</a>" +
        "      </div>" +
        "    </div>" +
        "    <button class='btn btn-sm btn-primary btn-labeled float-right'><i class='fas fa-plus'></i>Add item</button>" +
        "  </div>" +
        "  <div class='mb-4'>" +
        "    <input type='text' class='form-control' placeholder='Search for a post in the archive'>" +
        "  </div>" +
        "  <table class='table'>" +
        "    <tbody>" +
        "      <tr v-if='isSelected(post)' v-for='post in items' :class='post.status'>" +
        "        <td>" +
        "          <a href='#'>{{ post.title }}</a> " +
        "          <small v-if='post.status === \"published\"' class='text-muted'>| Published: {{ post.published }}</small>" +
        "          <small v-else-if='post.status === \"unpublished\"' class='text-muted'>| Unpublished</small>" +
        "        </td>" +
        "        <td>" +
        "          {{ post.typeName }}" +
        "        </td>" +
        "        <td>" +
        "          {{ post.category }}" +
        "        </td>" +
        "        <td class='actions one'>" +
        "          <a href='remove(post.id)' class='danger'><i class='fas fa-trash'></i></a>" +
        "        </td>" +
        "      </tr>" +
        "    </tbody>" +
        "  </table>" +
        "</div>"
});
